using Cirrious.CrossCore.IoC;
using System.Threading;

namespace Value.Core
{
    public class App : Cirrious.MvvmCross.ViewModels.MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();
				
            RegisterAppStart<ViewModels.FirstViewModel>();

            CreatePressureOnGc();
        }

        void CreatePressureOnGc()
        {
            ThreadPool.QueueUserWorkItem((ignored) =>
            {
                while (true)
                    new object();
            });
        }
    }
}