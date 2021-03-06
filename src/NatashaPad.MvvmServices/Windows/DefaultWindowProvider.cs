﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace NatashaPad.MvvmServices.Windows
{
    public class DefaultWindowProvider : IWindowProvider
    {
        public Window Create(object view, object viewModel)
        {
            if (!(view is Window window))
            {
                window = new Window();
                window.Content = view;
                window.SizeToContent = SizeToContent.WidthAndHeight;
            }

            window.DataContext = viewModel;
            return window;

            /* 
             * TODO: 可选的解法：
             * 在资源文件中定义View和ViewModel的映射关系
             * 预先设计好默认window
             * window中的内容元素的内容绑定到DataContext
             * 注册时，提供name，窗口尺寸等其它信息
             * 这样，就不需要在这个方法里硬编码，把扩展性开放出去
             */
        }
    }
}
