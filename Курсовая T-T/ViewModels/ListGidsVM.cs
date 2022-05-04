using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Курсовая_T_T.DTO;
using Курсовая_T_T.Model;
using Курсовая_T_T.Tools;

namespace Курсовая_T_T.ViewModels
{
    public class ListGidsVM : BaseVM
    {
        private List<int> pageIndexes;
        private int selectedIndex;
        private int viewRows;
        private List<Gids> listGids;
        public List<Gids> ListGids
        {
            get => listGids;
            set
            {
                listGids = value;
                Signal();
            }
        }

        public CommandVM ViewBack { get; set; }
        public CommandVM ViewForward { get; set; }
        public List<int> PageIndexes
        {
            get => pageIndexes;
            set
            {
                pageIndexes = value;
                Signal();
            }
        }

        public int SelectedIndex
        {
            get => selectedIndex;
            set
            {
                selectedIndex = value;
                ListGids = SqlModel.GetInstance().GidsList();
                Signal();
            }
        }
        public int ViewRows
        {
            get => viewRows;
            set
            {
                viewRows = value;
                InitPages();
                Signal();
            }
        }

        public ListGidsVM()
        {
            ViewRows = 2;

            ViewBack = new CommandVM(() =>
            {
                if (SelectedIndex > 1)
                    SelectedIndex--;
            });

            ViewForward = new CommandVM(() =>
            {
                if (SelectedIndex < PageIndexes.Last())
                    SelectedIndex++;
            });
        }

        private void InitPages()
        {
            var sqlModel = SqlModel.GetInstance();
            int pageCount = (sqlModel.GetNumRows(typeof(Gids)));
            PageIndexes = new List<int>(Enumerable.Range(1, pageCount));
            SelectedIndex = 1;
        }
    }
}
