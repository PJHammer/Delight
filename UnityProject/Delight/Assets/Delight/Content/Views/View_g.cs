// Internal view logic generated from "View.xml"
#region Using Statements
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
#endregion

namespace Delight
{
    public partial class View
    {
        #region Constructors

        static View()
        {
            var dependencyProperties = new List<DependencyProperty>();
            DependencyProperties.Add(ViewTemplates.Default, dependencyProperties);

            dependencyProperties.Add(LoadModeProperty);
            dependencyProperties.Add(StateProperty);
        }

        #endregion

        #region Properties

        public readonly static DependencyProperty<Delight.LoadMode> LoadModeProperty = new DependencyProperty<Delight.LoadMode>("LoadMode");
        public Delight.LoadMode LoadMode
        {
            get { return LoadModeProperty.GetValue(this); }
            set { LoadModeProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<System.String> StateProperty = new DependencyProperty<System.String>("State");
        public System.String State
        {
            get { return StateProperty.GetValue(this); }
            set { StateProperty.SetValue(this, value); }
        }

        #endregion
    }

    #region Data Templates

    public static class ViewTemplates
    {
        #region Properties

        public static Template Default
        {
            get
            {
                return View;
            }
        }

        private static Template _view;
        public static Template View
        {
            get
            {
#if UNITY_EDITOR
                if (_view == null || _view.CurrentVersion != Template.Version)
#else
                if (_view == null)
#endif
                {
                    _view = new Template(null);
                }
                return _view;
            }
        }

        #endregion
    }

    #endregion
}