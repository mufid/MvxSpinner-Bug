using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using XPlatformMenus.Core.ViewModels.Spinner;

namespace XPlatformMenus.Droid.Fragments
{
    [Register("xplatformmenus.droid.fragments.MvxSpinnerFragment")]
    public class MvxSpinnerFragment : BaseFragment<SpinnerViewModel>
    {
        protected override int FragmentId => Resource.Layout.fragment_spinner;
    }
}