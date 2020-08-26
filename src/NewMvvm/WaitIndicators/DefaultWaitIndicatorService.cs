using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace NewMvvm.WaitIndicators
{
    public class DefaultWaitIndicatorService : ICurrentWaitIndicatorService
    {
        private readonly Control view;

        public DefaultWaitIndicatorService(Control view)
        {
            this.view = view;
        }

        public void Close()
        {
            throw new NotImplementedException();
        }

        public void Complete(double value)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Show(object content)
        {
            throw new NotImplementedException();
        }
    }
}
