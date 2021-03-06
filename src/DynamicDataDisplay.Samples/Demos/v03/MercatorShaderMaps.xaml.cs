﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Microsoft.Research.DynamicDataDisplay.Samples.Demos.v03
{
	/// <summary>
	/// Interaction logic for MercatorShaderMap.xaml
	/// </summary>
	public partial class MercatorShaderMaps : Page
	{
		public MercatorShaderMaps()
		{
			InitializeComponent();

			UIElement messageGrid = (UIElement)Resources["warningMessage"];
			plotter.MainCanvas.Children.Add(messageGrid);
		}
	}
}
