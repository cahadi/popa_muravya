using System.Collections.Generic;
using System.Linq;
using Курсовая_T_T.DTO;
using Курсовая_T_T.Model;
using Курсовая_T_T.Tools;
using Курсовая_T_T.Pages;
using System;
using System.Windows.Controls;

namespace Курсовая_T_T.ViewModels
{
    class ViewTeaVM : BaseVM
    {
        
        private List<Tea> teaList;
        private List<int> pageIndexes;
        private int selectedIndex;
        private int viewRowsCount;

        public List<Tea> TeaList
        {
            get => teaList;
            set
            {
                teaList = value;
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
                TeaList = SqlModel.GetInstance().TeaList();
                Signal();
            }
        }
        public int[] RowsCountVariants { get; set; }
        public int ViewRowsCount
        {
            get => viewRowsCount;
            set
            {
                viewRowsCount = value;
                InitPages();
                Signal();
            }
        }

        public ViewTeaVM()
        {
            RowsCountVariants = new int[] { 2, 5, 10 };
            ViewRowsCount = 5;

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
            int pageCount = (sqlModel.GetNumRows(typeof(Tea)) / ViewRowsCount) + 1;
            PageIndexes = new List<int>(Enumerable.Range(1, pageCount));
            SelectedIndex = 1;
        }


    }
}
