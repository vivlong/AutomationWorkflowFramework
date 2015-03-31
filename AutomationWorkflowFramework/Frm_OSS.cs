using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DeveloperTools
{
    public partial class Frm_OSS : Form
    {
        //private Classes.ListViewColumnSorter lvwColumnSorter;

        public Frm_OSS()
        {
            InitializeComponent();
            //btn_Refresh_Click(btn_Refresh,new EventArgs());
        }

        //private void CreateViewItem()
        //{
        //    listView1.BeginUpdate();
        //    listView1.Columns.Add("FileName",380);
        //    listView1.Columns.Add("KeyName", 0);
        //    listView1.Columns.Add("Size",60);
        //    listView1.Columns.Add("Upload Datetime",140);
        //    listView1.Columns.Add("MIME Type",100);
        //    LoadListViewItems();
        //    listView1.EndUpdate();
        //}

        //private void LoadListViewItems()
        //{

        //    Qiniu.RSF.RSFClient client = new Qiniu.RSF.RSFClient("sysmagic");
        //    Qiniu.RSF.DumpRet ret = client.ListPrefix("sysmagic");
        //    int itemCount = ret.Items.Count;
        //    for (int i = 0; i <= itemCount - 1; i++)
        //    {
        //        string str_Size = "";
        //        long kb = ret.Items[i].FSize / 1024;
        //        long mb = 0;
        //        if (kb > 1024)
        //        {
        //            mb = kb / 1024;
        //        }
        //        if (mb != 0)
        //        {
        //            str_Size = mb.ToString() + "MB";
        //        }
        //        else
        //        {
        //            str_Size = kb.ToString() + "KB";
        //        }
        //        string key = ret.Items[i].Key;
        //        string str_Datetime = GetTime(ret.Items[i].PutTime).ToString("yy/MM/dd HH:mm:ss");
        //        string str_mimeType = ret.Items[i].Mime.Replace("application/", "");
        //        listView1.Items.Add(ret.Items[i].Hash,key.Substring(key.LastIndexOf("/") + 1),0);
        //        listView1.Items[ret.Items[i].Hash].SubItems.Add(ret.Items[i].Key);
        //        listView1.Items[ret.Items[i].Hash].SubItems.Add(str_Size);
        //        listView1.Items[ret.Items[i].Hash].SubItems.Add(str_Datetime);
        //        listView1.Items[ret.Items[i].Hash].SubItems.Add(str_mimeType);
        //    }
        //}

        //private DateTime GetTime(long lTime)
        //{
        //    DateTime dtStart = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
        //    TimeSpan toNow = new TimeSpan(lTime);
        //    return dtStart.Add(toNow);
        //}

        //private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        //{
        //    if (e.Column == lvwColumnSorter.SortColumn)
        //    {
        //        if (lvwColumnSorter.Order == SortOrder.Ascending)
        //        {
        //            lvwColumnSorter.Order = SortOrder.Descending;
        //        }
        //        else
        //        {
        //            lvwColumnSorter.Order = SortOrder.Ascending;
        //        }
        //    }
        //    else
        //    {
        //        lvwColumnSorter.SortColumn = e.Column;
        //        lvwColumnSorter.Order = SortOrder.Ascending;
        //    }
        //    this.listView1.Sort();
        //}

        //private void listView1_DoubleClick(object sender, EventArgs e)
        //{
        //    if (listView1.SelectedItems.Count > 0)
        //    {
        //        string key = listView1.SelectedItems[0].SubItems[1].Text.ToString();
        //        string sourceUrl = Qiniu.RS.GetPolicy.MakeBaseUrl("sysmagic.qiniudn.com", key);
        //        string mimeType = listView1.SelectedItems[0].SubItems[4].Text.ToString();
        //        string filter = "All Files（*.*）|*.*";
        //        switch (mimeType)
        //        {
        //            case "msword":
        //                filter = "Word (*.doc)|*.doc";
        //                break;
        //            case "vnd.ms-excel":
        //                filter = "Excel (*.xls)|*.xls";
        //                break;
        //            case "pdf":
        //                filter = "PDF (*.pdf)|*.pdf";
        //                break;
        //            case "rar":
        //                filter = "RAR (*.rar)|*.rar";
        //                break;
        //            default :
        //                filter = "ZIP (*.zip)|*.zip";
        //                break;
        //        }
        //        SaveFileDialog sfd = new SaveFileDialog();
        //        sfd.RestoreDirectory = true;
        //        sfd.FileName = key.Substring(key.LastIndexOf("/") + 1);
        //        sfd.Filter = filter;
        //        if (sfd.ShowDialog() == DialogResult.OK)
        //        {
        //            this.panel1.Enabled = false;
        //            string localFilePath = sfd.FileName.ToString();
        //            Class.HttpLoadFile hlf = new Class.HttpLoadFile(sourceUrl, 5, localFilePath);
        //            if (hlf.DownLoad())
        //            {
        //                MessageBox.Show("Download success!");
        //            }
        //            else
        //            {
        //                MessageBox.Show("Download failed, you might need to try it again!");
        //            }
        //            this.panel1.Enabled = true;
        //        }
        //    }
        //}

        //private void btn_Refresh_Click(object sender, EventArgs e)
        //{
        //    listView1.Clear();
        //    lvwColumnSorter = new Class.ListViewColumnSorter();
        //    this.listView1.ListViewItemSorter = lvwColumnSorter;
        //    CreateViewItem();
        //}
    }
}
