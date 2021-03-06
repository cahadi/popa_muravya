using System.Collections.Generic;
using System.Linq;
using Курсовая_T_T.DTO;
using Курсовая_T_T.Model;
using Курсовая_T_T.Pages;
using Курсовая_T_T.Tools;

namespace Курсовая_T_T.ViewModels
{
    public class GroupVM : BaseVM
    {
        public Group AddGroup { get; set; }
        public CommandVM SaveGroup { get; set; }

        private CurrentPageControl currentPageControl;

        public GroupVM(CurrentPageControl currentPageControl)
        {
            this.currentPageControl = currentPageControl;
            AddGroup = new Group();
            Init();
        }

        public GroupVM(Group addGroup, CurrentPageControl currentPageControl)
        {
            AddGroup = addGroup;
            this.currentPageControl = currentPageControl;
            Init();
        }

        private void Init()
        {
            SaveGroup = new CommandVM(() => {
                var model = SqlModel.GetInstance();
                if (AddGroup.ID == 0)
                    model.Insert(AddGroup);
                currentPageControl.Back();
            });
        }
    }
}
