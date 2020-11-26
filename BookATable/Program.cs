namespace BookATable
{
    using System;
    using System.Windows.Forms;

    using GUI;

    public static class Program
    {
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            /************************************************************************
            ** 
            **  Remove below comments in BookATable.cs after storing an administrator
            **
            ************************************************************************/

            //FormLogin formLogin = new FormLogin();
            //if (formLogin.ShowDialog() == DialogResult.OK)
            //{
            Application.Run(new FormMain());
            //}
        }
    }
}
