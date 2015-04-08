using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Net;
using System.IO;

namespace AWF.Classes
{
    public class HttpLoadFile
    {
        private bool isFinish=false;
        /// <summary>
        /// 全局下载完成标志
        /// </summary>
        public bool IsFinish
        {
            get { return isFinish; }           
        }

        private bool[] isFinishList;    //每个线程结束标志
        /// <summary>
        /// 结束标志
        /// </summary>
        public bool[] IsFinishList
        {
            get { return isFinishList; }           
        }
        private string[] taskFileList;  
        /// <summary>
        /// 每个线程接收的拆分文件 提供给各线程使用 helper
        /// </summary>
        public string[] TaskFileList
        {
            get { return taskFileList; }            
        }
        private int[] taskStartList;    
        /// <summary>
        /// 每个线程接收拆分后文件的起始位置 提供给各线程使用 helper类
        /// </summary>
        public int[] TaskStartList
        {
            get { return taskStartList; }
        }

        private int[] taskSizeList;    
        /// <summary>
        /// /每个线程接收拆分后文件的大小 提供给各线程使用 helper
        /// </summary>
        public int[] TaskSizeList
        {
            get { return taskSizeList; }            
        }

        private string sourceUrl;       //接受文件的URL
        /// <summary>
        /// 下载源链接
        /// </summary>
        public string SourceUrl
        {
            get { return sourceUrl; }
            set { sourceUrl = value; }
        }       

        private int taskCount;          //进程数 
        /// <summary>
        /// 开启下载线程数
        /// </summary>
        public int TaskCount
        {
            get { return taskCount; }
            set { taskCount = value; }
        }       

        private string saveFilePath;
        /// <summary>
        /// 存储文件位置
        /// </summary>
        public string SaveFilePath
        {
            get { return saveFilePath; }
            set { saveFilePath = value; }
        }

        private string errMsg;
        /// <summary>
        /// 出错信息
        /// </summary>
        public string ErrMsg
        {
            get { return errMsg; }           
        }

        private HttpWebRequest request;
        private bool isMerge;           //文件合并标志
        private long fileSize = 0;      //源文件大小

        /// <summary>
        /// 错误通知
        /// </summary>
        public event EventHandler<HttpLoadFileEventArgs> Error;
        /// <summary>
        /// 全部下载完成通知
        /// </summary>
        public event EventHandler<HttpLoadFileEventArgs> AllFinished;
        /// <summary>
        /// 子线程完成通知
        /// </summary>
        public event EventHandler<HttpLoadFileEventArgs> SubFinished;

        /// <summary>
        /// 构造函数 提供下载链接，使用几线程下载，存储文置
        /// </summary>
        /// <param name="sourceUrl">下载链接</param>
        /// <param name="taskCount">开启几线程下载</param>
        /// <param name="saveFilePath">存储文置</param>
        public HttpLoadFile(string sourceUrl, int taskCount, string saveFilePath)
        {
            this.sourceUrl = sourceUrl;
            this.taskCount = taskCount;
            this.saveFilePath = saveFilePath;
        }

        public bool DownLoad()
        {
            try
            {
                //初始化连接
                InitConnection();
                //开始每个线程下载
                DownLoadTask();
                //完成通知外界定制类
                isFinish = true;
                AllFinishNotify();
                return true;
            }
            catch
            {
                //失败通知外界定制类
                isFinish = false;
                AllErrorNotify();
                return false;
            }
        }

        /// <summary>
        /// 全局任务出错触发事件通知方法
        /// </summary>
        protected void AllErrorNotify()
        {
            if (Error != null)
            {
                HttpLoadFileEventArgs args = new HttpLoadFileEventArgs();
                args.TaskCount = taskCount;
                args.SourceUrl = sourceUrl;
                args.SaveFilePath = saveFilePath;
                args.IsFinish = false;
                args.ErrMsg = errMsg;
                Error(this, args);
            }
        }

        /// <summary>
        /// 全部任务完成触发事件通知方法
        /// </summary>
        protected void AllFinishNotify()
        {
            if (AllFinished != null)
            {
                HttpLoadFileEventArgs args = new HttpLoadFileEventArgs();
                args.TaskCount = taskCount;
                args.SourceUrl = sourceUrl;
                args.SaveFilePath = saveFilePath;
                args.IsFinish = true;
                args.ErrMsg = "No Error!";
                args.TaskIndex = taskCount;
                AllFinished(this, args);
            }
        }

        /// <summary>
        /// 子任务线程出错触发事件通知方法
        /// <param name="args"></param>
        protected void SubErrorNotify(HttpLoadFileEventArgs args)
        {
            if (Error != null)
            {               
                Error(this, args);
            }
        }

        /// <summary>
        /// 子任务线程完成触发事件通知方法
        /// </summary>
        /// <param name="args"></param>
        protected void SubFinishNotity(HttpLoadFileEventArgs args)
        {
            if (SubFinished != null)
            {
                SubFinished(this, args);
            }
        }
        
        protected void DownLoadTask()
        {
            try
            {
                //定义线程数组，启动接收线程
                Thread[] threadList = new Thread[this.taskCount];
                LoadFileHelper[] helpers = new LoadFileHelper[taskCount];
                for (int j = 0; j < taskCount; j++)
                {
                    helpers[j] = new LoadFileHelper(this, j);
                    //当各线程下载完或下载出错，请通知主类更新 下载结束标志或出错信息
                    helpers[j].Error+=new EventHandler<HttpLoadFileEventArgs>(HttpLoadFile_Error);
                    helpers[j].Finished += new EventHandler<HttpLoadFileEventArgs>(HttpLoadFile_Finished);
                    threadList[j] = new Thread(new ThreadStart(helpers[j].LoadTaskFile));
                    threadList[j].Start();
                }
                //启动合并各线程接收的文件线程
                Thread mergeThread = new Thread(new ThreadStart(MergeFile));
                mergeThread.Start();                
            }
            catch (Exception ex)
            {
                throw new Exception("开始多线程任务下载出错：" + ex.Message);                
            }
        }

        protected void HttpLoadFile_Error(object sender, HttpLoadFileEventArgs e)
        {
            errMsg = e.ErrMsg;
            SubErrorNotify(e);
        }

        protected void HttpLoadFile_Finished(object sender, HttpLoadFileEventArgs e)
        {
            isFinishList[e.TaskIndex] = e.IsFinish;
            SubFinishNotity(e);
        }

        ~HttpLoadFile()//析构方法
        {
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// 试连接并获取文件大小
        /// </summary>
        protected void InitConnection()
        {            
            try
            {
                request = (HttpWebRequest)HttpWebRequest.Create(sourceUrl);
                fileSize = request.GetResponse().ContentLength;   //取得目标文件的长度
                request.Abort();
               
                //根据线程数初始化数组
                isFinishList = new bool[taskCount];
                taskFileList = new string[taskCount];
                taskStartList = new int[taskCount];
                taskSizeList = new int[taskCount];
                //计算每个任务的要下载的文件大小及起点位置
                InitTaskList();               
            }
            catch (HttpListenerException ex)
            {
                 throw new Exception("无法连接目标地址,原因" + ex.Message);                         
            }
            
        }

        /// <summary>
        /// 拆分计算出每个任务接收文件的大小和接收起点位置
        /// </summary>
        protected void InitTaskList()
        {
            //计算每个线程应该接收文件的大小
            int averageTaskFileSize = (int)fileSize / taskCount;//平均分配
            int lasTaskFileSize = averageTaskFileSize + (int)fileSize % taskCount;//剩余部分由最后一个线程完成
            //为数组赋值
            for (int i = 0; i < taskCount; i++)
            {
                isFinishList[i] = false;//每个线程状态的初始值为假
                taskFileList[i] = i.ToString() + ".dat";//每个线程接收文件的临时文件名
                if (i < taskCount - 1)
                {
                    taskStartList[i] = averageTaskFileSize * i;//每个线程接收文件的起始点
                    taskSizeList[i] = averageTaskFileSize - 1;//每个线程接收文件的长度
                }
                else
                {
                    taskStartList[i] = averageTaskFileSize * i;
                    taskSizeList[i] = lasTaskFileSize - 1;
                }
            }
        }

        /// <summary>
        /// 合并各任务下载的文件，并存于指定位置
        /// </summary>
        /// <returns></returns>
        protected  void MergeFile()
        {
            //开始合并
            FileStream fs = null;
            FileStream fstemp = null;

            try
            {
                while (true)//等待
                {
                    isMerge = true;
                    for (int i = 0; i < taskCount; i++)
                    {
                        if (isFinishList[i] == false)//有未结束线程，等待
                        {
                            isMerge = false;
                            Thread.Sleep(100);
                            break;
                        }
                    }
                    if (isMerge == true)//所有线程均已结束，停止等待，
                    {
                        break;
                    }
                }

                int readfile;
                byte[] bytes = new byte[512];
                fs = new FileStream(saveFilePath, System.IO.FileMode.Create);
                for (int k = 0; k < taskCount; k++)
                {
                    fstemp = new FileStream(taskFileList[k], System.IO.FileMode.Open);
                    while (true)
                    {
                        readfile = fstemp.Read(bytes, 0, 512);
                        if (readfile > 0)
                        {
                            fs.Write(bytes, 0, readfile);
                        }
                        else
                        {
                            break;
                        }
                    }
                    fstemp.Close();
                }
                fs.Close();               
            }
            catch (IOException ex)
            { 
                fstemp.Close();
                fs.Close();
                throw new Exception("合并任务文件出错，原因：" + ex.Message);
                               
            }           
        }

        
    }

    /// <summary>
    /// HttpLoadFile 事件参数类
    /// </summary>
    public class HttpLoadFileEventArgs : EventArgs
    {
        private int taskCount;          //进程数 
        /// <summary>
        /// 开启下载线程数
        /// </summary>
        public int TaskCount
        {
            get { return taskCount; }
            set { taskCount = value; }
        }

        private string sourceUrl;
        /// <summary>
        /// 下载源链接
        /// </summary>
        public string SourceUrl
        {
            get { return sourceUrl; }
            set { sourceUrl = value; }
        }

        private string saveFilePath;
        /// <summary>
        /// 存储文件位置
        /// </summary>
        public string SaveFilePath
        {
            get { return saveFilePath; }
            set { saveFilePath = value; }
        }

        private string errMsg;
        /// <summary>
        ///  错误信息
        /// </summary>
        public string ErrMsg
        {
            get { return errMsg; }
            set { errMsg = value; }
        }


        private bool isFinish;
        /// <summary>
        /// 完成标志
        /// </summary>
        public bool IsFinish
        {
            get { return isFinish; }
            set { isFinish = value; }
        }

        private int taskIndex;
        /// <summary>
        /// 当前第几个线程
        /// </summary>
        public int TaskIndex
        {
            get { return taskIndex; }
            set { taskIndex = value; }
        }

        public HttpLoadFileEventArgs()
        { }

    }

    /// <summary>
    /// 用于Thread线程调用的类（M线程委托的方法如果带参数可以通过类把其参数封装成属性或变量）
    /// </summary>
    class LoadFileHelper
    {
        private HttpWebRequest request;
        private HttpLoadFile httpLoadFile;
        private int taskIndex;
        private string errMsg;       

        public event EventHandler<HttpLoadFileEventArgs> Error;
        public event EventHandler<HttpLoadFileEventArgs> Finished;

        public LoadFileHelper(HttpLoadFile httpLoadFile, int taskIndex)
        {
            this.httpLoadFile = httpLoadFile;
            this.taskIndex = taskIndex;
        }

        /// <summary>
        /// 根据任务编号开启每个任务下载
        /// </summary>
        /// <param name="taskIndex"></param>
        public void LoadTaskFile()
        {
            FileStream fs;
            System.IO.Stream ns;
            byte[] nbytes;//接收缓冲区
            int nreadsize;//接收字节数

            ns = null;
            nbytes = new byte[512];
            nreadsize = 0;
            //("线程" + taskIndex.ToString() + "开始接收");-----------------------------------------关注每个任务线程开始

            fs = new FileStream(httpLoadFile.TaskFileList[taskIndex], System.IO.FileMode.Create);
            try
            {
                request = (HttpWebRequest)WebRequest.Create(httpLoadFile.SourceUrl);
                //接收的起始位置及接收的长度 
                request.AddRange(httpLoadFile.TaskStartList[taskIndex], httpLoadFile.TaskStartList[taskIndex] + httpLoadFile.TaskSizeList[taskIndex]);
                ns = request.GetResponse().GetResponseStream();//获得接收流
                nreadsize = ns.Read(nbytes, 0, 512);
                while (nreadsize > 0)
                {
                    fs.Write(nbytes, 0, nreadsize);
                    nreadsize = ns.Read(nbytes, 0, 512);
                    //("线程" + taskIndex.ToString() + "正在接收");----------------------------------关注每个任务线程进行
                }
                fs.Close();
                ns.Close();
                //("进程" + taskIndex.ToString() + "接收完毕!");-----------------------------------------关注每个任务线程结束
                //httpLoadFile.IsFinishList[taskIndex] = true;

                //触发事件通知HttpDownLoad下载完毕，并更新对应IsFinishList[taskIndex]结束标识的状态
                FinishNotify();
            }
            catch (HttpListenerException ex)
            {
                errMsg = "第[" + taskIndex.ToString() + "]条任务线程发生错误，原因：" + ex.Message;
                ns.Close();
                fs.Close();
                //触发事件通知其中某个线程下载任务出错
                ErrorNotify();
            }

            
        }

        protected void FinishNotify()
        { 
            if(Finished!=null)
            {
                HttpLoadFileEventArgs args = new HttpLoadFileEventArgs();
                args.TaskIndex = this.taskIndex;
                args.IsFinish=true;
                args.ErrMsg= "No Error!";
                args.SourceUrl = httpLoadFile.SourceUrl;
                args.SaveFilePath = httpLoadFile.SaveFilePath;
                args.TaskCount = httpLoadFile.TaskCount;
                
                Finished(this, args);
            }
        }

        protected void ErrorNotify()
        {
            if (Error != null)
            {
                HttpLoadFileEventArgs args = new HttpLoadFileEventArgs();
                args.TaskIndex = this.taskIndex;
                args.IsFinish = false;
                args.ErrMsg = errMsg;
                args.SourceUrl = httpLoadFile.SourceUrl;
                args.SaveFilePath = httpLoadFile.SaveFilePath;
                args.TaskCount = httpLoadFile.TaskCount;
                Error(this, args);
            }
        }
    }
}
