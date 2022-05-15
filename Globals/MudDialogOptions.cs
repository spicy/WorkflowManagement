using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkflowManagement.Globals
{
    public static class MudDialogOptions
    {
        public static DialogOptions noHeader = new DialogOptions() { NoHeader = true };
        public static DialogOptions fullWidth = new DialogOptions() { FullWidth = true };

        /// <summary>
        /// Dynamically creates a DialogOptions object by the given arguments
        /// </summary>
        /// <param name="position"></param>
        /// <param name="maxWidth"></param>
        /// <param name="disableBackdropClick"></param>
        /// <param name="noHeader"></param>
        /// <param name="closeButton"></param>
        /// <param name="fullScreen"></param>
        /// <param name="fullWidth"></param>
        /// <returns>DialogOptions object</returns>
        public static DialogOptions CreateDialogOptions(DialogPosition? position = null, MaxWidth? maxWidth = null,
                                                        bool? disableBackdropClick = null, bool? noHeader = null, bool? closeButton = null, 
                                                        bool? fullScreen = null, bool? fullWidth = null)
        {
            return new DialogOptions() {
                Position                = position == null ? DialogPosition.Center : position,
                MaxWidth                = maxWidth == null ? MaxWidth.Large : maxWidth,
                DisableBackdropClick    = disableBackdropClick == null ? false : disableBackdropClick,
                NoHeader                = noHeader == null ? false : noHeader,
                CloseButton             = closeButton == null ? true : closeButton,
                FullScreen              = fullScreen == null ? false : fullScreen,
                FullWidth               = fullWidth == null ? false : fullWidth
            };
        }
    }
}
