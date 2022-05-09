using System.Collections.Generic;
using System.Linq;
using Курсовая_T_T.DTO;
using Курсовая_T_T.Model;
using Курсовая_T_T.Tools;

namespace Курсовая_T_T.ViewModels
{
    public class GroupVM : BaseVM
    {
        public Group AddGroup { get; set; }
        public CommandVM Add { get; set; }

        private CurrentPageControl currentPageControl;

        public GroupVM(CurrentPageControl currentPageControl)
        {
            this.currentPageControl = currentPageControl;
            AddGroup = new Group();
            Init();
        }
        public GroupVM(Group addgroup, CurrentPageControl currentPageControl)
        {
            this.currentPageControl = currentPageControl;
            AddGroup = addgroup;
            Init();
        }

        private void Init()
        {
            Add = new CommandVM(() => {
                
                var model = SqlModel.GetInstance();
                if (AddGroup.ID == 0)
                    model.Insert(AddGroup);
                else
                    model.Update(AddGroup);
                currentPageControl.Back();
            });
        }
    }
}
