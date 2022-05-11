using System.Collections.Generic;
using System.Linq;
using Курсовая_T_T.DTO;
using Курсовая_T_T.Model;
using Курсовая_T_T.Pages;
using Курсовая_T_T.Tools;

namespace Курсовая_T_T.ViewModels
{
    public class UserProfileVM : BaseVM
    {
        public Comment EditComment { get; }
        public CommandVM SaveComment { get; set; }


        private CurrentPageControl currentPageControl;

        public UserProfileVM(CurrentPageControl currentPageControl)
        {
            this.currentPageControl = currentPageControl;
            EditComment = new Comment();
            Init();
        }

        public UserProfileVM(Comment editComment, CurrentPageControl currentPageControl)
        {
            EditComment = editComment;
            this.currentPageControl = currentPageControl;
            Init();
        }

        private void Init()
        {
            SaveComment = new CommandVM(() => {
                var model = SqlModel.GetInstance();
                if (EditComment.ID == 0)
                    model.Insert(EditComment);
                System.Windows.MessageBox.Show("Благодарим за отзыв");
            });
        }

    }
}