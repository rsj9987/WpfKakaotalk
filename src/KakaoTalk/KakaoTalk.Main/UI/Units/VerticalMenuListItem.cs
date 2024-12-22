﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KakaoTalk.Main.UI.Units
{
    public class VerticalMenuListItem : ListBoxItem
    {
        static VerticalMenuListItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(VerticalMenuListItem), new FrameworkPropertyMetadata(typeof(VerticalMenuListItem)));
        }
    }
}
