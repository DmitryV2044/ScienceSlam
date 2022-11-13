namespace ScienceSlam
{
    public partial class CurrentEventAlt : ContentPage
    {
        public CurrentEventAlt(CurrentEventPageAltModel cpam)
        {
           // InitializeComponent();
            BindingContext = cpam;
        }
    }

}
