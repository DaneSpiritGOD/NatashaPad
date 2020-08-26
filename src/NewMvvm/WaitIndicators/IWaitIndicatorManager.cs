using System;
using System.Collections.Generic;
using System.Text;

namespace NewMvvm.WaitIndicators
{
    public interface IWaitIndicatorManager
    {
        ICurrentWaitIndicatorService GetCurrent<TViewModel>(TViewModel viewModel);
    }
}
