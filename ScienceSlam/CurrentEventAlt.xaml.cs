namespace ScienceSlam
{
    public partial class CurrentEventAlt : ContentPage
    {
        public CurrentEventAlt(CurrentEventPageAltModel cpam)
        {
            // InitializeComponent(); //InitializeComponent() does not found...
            BindingContext = cpam;
        }
    }

}
