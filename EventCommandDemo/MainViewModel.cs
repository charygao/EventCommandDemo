using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;

namespace EventCommandDemo
{
    public class MainViewModel : ViewModelBase
    {

        public MainViewModel()
        {
            cboMouseEnterCommand = new ViewModelCommand((Object parameter) => { cboMouseEnterEvent(); });
            cboTextBoxChangedCommand = new ViewModelCommand((Object parameter) => { cboTextBoxChangedEvent(); });
            cboTextBoxBaseChangedCommand = new ViewModelCommand((Object parameter) => { cboTextBoxBaseChangedEvent(); });
            cboSelectionChangedCommand = new ViewModelCommand((Object parameter) => { cboSelectionChangedEvent(); });
            btnClickCommand = new ViewModelCommand((Object parameter) => { btnClickEvent(); });
            btnMouseDoubleClickCommand = new ViewModelCommand((Object paramenter) => { btnMouseDoubleClickEvent(); });
            pwdGotFocusCommand = new ViewModelCommand((Object paramenter) => { pwdGotFocusEvent(); });
            chkCheckedCommand = new ViewModelCommand((Object paramenter) => { chkCheckedEvent(); });
            chkUncheckedCommand = new ViewModelCommand((Object paramenter) => { chkUncheckedEvent(); });

            var tempList =new string[]{"一个","两个","三个"};
            ListCollection = tempList;
        }

        #region 事件命令
        /// <summary>
        /// 下拉框 鼠标进入事件命令
        /// </summary>
        public ICommand cboMouseEnterCommand { get; private set; }
        /// <summary>
        /// 下拉框文本改变事件命令,通过TextBox.TextChanged
        /// </summary>
        public ICommand cboTextBoxChangedCommand { get;private set; }
        /// <summary>
        /// 下拉框文本改变事件命令,通过TextBoxBase.TextChanged
        /// </summary>
        public ICommand cboTextBoxBaseChangedCommand { get; private set; }

        /// <summary>
        /// 下拉框，选中事件
        /// </summary>
        public ICommand cboSelectionChangedCommand { get; private set; }

        /// <summary>
        /// 登陆按钮单机事件命令
        /// </summary>
        public ICommand btnClickCommand { get; private set; }

        /// <summary>
        /// 登陆按钮双击事件命令
        /// </summary>
        public ICommand btnMouseDoubleClickCommand { get; private set; }
        /// <summary>
        /// 密码框获取焦点事件命令
        /// </summary>
        public ICommand pwdGotFocusCommand { get; private set; }

        /// <summary>
        /// 多选框非选中事件命令
        /// </summary>
        public ICommand chkUncheckedCommand { get;private set; }
        /// <summary>
        /// 多选框选中事件命令
        /// </summary>
        public ICommand chkCheckedCommand { get;private set; }
     

        #endregion

        #region 事件执行方法
        /// <summary>
        /// 下拉框 鼠标进入事件,执行方法。
        /// </summary>
        private void cboMouseEnterEvent()
        {
            MessageBox.Show("下拉框，鼠标进入事件被触发了");
        }

        /// <summary>
        /// 下拉框文本改变事件,执行方法
        /// </summary>
        private void cboTextBoxBaseChangedEvent()
        {
            MessageBox.Show("TextBoxBase - 用户名输入，下拉框文本改变事件被触发了");
        }

        private void cboTextBoxChangedEvent()
        {
            MessageBox.Show("TextBox - 用户名输入，下拉框文本改变事件被触发了");
        }

        /// <summary>
        /// 下拉框选中事件，执行方法
        /// </summary>
        private void cboSelectionChangedEvent()
        {
            MessageBox.Show("下拉框，下拉框选中一个Item事件被触发了");
        }
        /// <summary>
        /// 登陆按钮单机事件,执行方法
        /// </summary>
        private void btnClickEvent()
        {
            MessageBox.Show("登陆按钮，鼠标单机（Click）事件被触发了");
        }

        /// <summary>
        /// 登陆按钮双击事件，执行方法
        /// </summary>
        private void btnMouseDoubleClickEvent()
        {
            MessageBox.Show("登陆按钮，鼠标双击事件被触发了");
        }

        /// <summary>
        /// 密码框获取焦点事件，执行方法
        /// </summary>
        private void pwdGotFocusEvent()
        {
            MessageBox.Show("密码框获取了焦点，事件被触发了");
        }

        /// <summary>
        /// 多选框，非选中状态事件，执行方法
        /// </summary>
        private void chkUncheckedEvent()
        {
            MessageBox.Show("多选框没选中，事件被触发了");
        }
        /// <summary>
        /// 多选框，选中状态事件，执行方法
        /// </summary>
        private void chkCheckedEvent()
        {
            MessageBox.Show("多选框选中，事件被触发了");
        }
        #endregion

        #region 成员
        private string[] listCollection;
        #endregion

        #region 属性
        public string[] ListCollection { get { return listCollection; } set { this.SetProperty(ref this.listCollection,value);} }
        #endregion

    }
}
