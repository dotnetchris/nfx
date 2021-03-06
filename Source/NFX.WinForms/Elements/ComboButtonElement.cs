/*<FILE_LICENSE>
* NFX (.NET Framework Extension) Unistack Library
* Copyright 2003-2016 IT Adapter Inc.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
* http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
</FILE_LICENSE>*/


using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using System.Drawing;

using NFX.WinForms;

namespace NFX.WinForms.Elements
{
  /// <summary>
  /// Represents a combo box button element
  /// </summary>
  public class ComboButtonElement : PressableElement
  {
    #region .ctor

      public ComboButtonElement(ElementHostControl host)
        : base(host)
      {
      }

    #endregion


    #region Private Fields

    #endregion


    #region Properties

    #endregion


    #region Events


    #endregion


    #region Public

    #endregion


    #region Protected


        protected internal override void Paint(System.Drawing.Graphics gr)
        {
          base.Paint(gr);
          //BaseApplication.Theme.PartRenderer.ComboButton(gr,
          //                                          Region,
          //                                          MouseIsOver,
          //                                          Pressed,
          //                                          FieldControlContext);
        }


    #endregion


    #region Private Utils



    #endregion

  }

}
