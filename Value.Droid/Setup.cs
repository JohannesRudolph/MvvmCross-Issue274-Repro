using Android.Content;
using Cirrious.MvvmCross.Droid.Platform;
using Cirrious.MvvmCross.ViewModels;
using System;
using System.Threading;
using Value.Core;

namespace Value.Droid
{
    public class Setup : MvxAndroidSetup
    {
        public Setup(Context applicationContext) : base(applicationContext)
        {
        }
        
        static int initialized = 1;

        protected override IMvxApplication CreateApp()
        {
            Guid g = Guid.NewGuid();
            Console.WriteLine( "initialization of setup: " + g.ToString() );

            if (Interlocked.CompareExchange( ref initialized, 0, 1 ) == 0)
                Console.WriteLine( "detected duplicate initialization!" );

            var app = default(Value.Core.App);

            // ensure we perform this on the main thread
            // we want a synchronous invocation, so we use send here
            Android.App.Application.SynchronizationContext.Send(
                _ => app = new App( ), null );

            return app;
        }

    }
}