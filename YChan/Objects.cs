using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YChan
{
    public class RefreshingListBox : ListBox
    {
        public new void RefreshItem(int index)
        {
            base.RefreshItem(index);
        }

        public new void RefreshItems()
        {
            base.RefreshItems();
        }
    }

    public class IBDownloadItem
    {
        public string URL;
        public bool OverrideThreadName = false;
        public string ThreadName;
        public IBThreadState State;

        public IBDownloadItem(string _url)
        {
            URL = _url;
            ThreadName = "";
            State = IBThreadState.PENDING;
        }

        public override string ToString()
        {
            string safeName = ThreadName.Trim();

            if (safeName == "" && State != IBThreadState.PENDING)
                safeName = "~no thread title~";

            return UrlMinimizer(URL) + " ▶ " + safeName + " ▶ " + State.ToString();
        }

        private string UrlMinimizer(string URL)
        {
            string miniUrl = URL;

            if (miniUrl == null)
                return "null";

            miniUrl = miniUrl.Replace("http://boards.4chan.org", "4chan ");
            miniUrl = miniUrl.Replace("thread/", " ");

            return miniUrl;
        }
    }

    public enum IBThreadState
    {
        PENDING,
        ONGOING,
        ARCHIVED,
        DELETED
    }
}
