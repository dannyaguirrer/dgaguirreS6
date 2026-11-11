using Microsoft.Extensions.DependencyInjection;

namespace dgaguirreS6
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new Views.vEstudiantes());
        }
    }
}