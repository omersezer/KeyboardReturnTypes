using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace KeyboardType.CustomRenderers
{
    public class CustomEntry : Entry
    {
        public new event EventHandler Completed;

        public static readonly BindableProperty ReturnTypeProperty = BindableProperty.Create(
            nameof(ReturnType),
            typeof(ReturnType),
            typeof(CustomEntry),
            ReturnType.Done,
            BindingMode.OneWay);

        public ReturnType ReturnType
        {
            get { return (ReturnType)GetValue(ReturnTypeProperty); }
            set { SetValue(ReturnTypeProperty, value); }
        }

        public void InvokeCompleted()
        {
            if (this.Completed != null)
                this.Completed.Invoke(this, null);
        }
    }
}
