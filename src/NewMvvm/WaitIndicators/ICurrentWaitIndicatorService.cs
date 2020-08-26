using System;
using System.Collections.Generic;
using System.Text;

namespace NewMvvm.WaitIndicators
{
    public interface ICurrentWaitIndicatorService : IDisposable
    {
        void Show(object content);

        void Complete(double value);

        void Close();
    }

    public static class WaitIndicatorExtensions
    {
        public const double CompleteValue = 1d;

        public static void Complete(this ICurrentWaitIndicatorService currentWaitIndicator)
        {
            currentWaitIndicator.Complete(CompleteValue);
            currentWaitIndicator.Close();
        }
    }
}
