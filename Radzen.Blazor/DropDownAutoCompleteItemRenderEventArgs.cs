using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radzen.Blazor
{
	/// <summary>
	/// Supplies information about RadzenDropDownAutoComplete ItemRender event.
	/// </summary>
	public class DropDownAutoCompleteItemRenderEventArgs<TValue> : DropDownBaseItemRenderEventArgs<TValue>
	{
		/// <summary>
		/// Gets the DropDown.
		/// </summary>
		public RadzenDropDownAutoComplete<TValue> DropDown { get; internal set; }
	}
}
