namespace BlazorStudent.Client.Helpers
{
    public static class SweetAlert
    {
        public static string icon_success = "success";
        public static string icon_error = "error";
        public static string icon_warning = "warning";
        public static string icon_info = "info";
        public static string icon_question = "question";
        public static string position_top_end = "top-end";
        public static string position_top_start = "top-start";
        public static string position_top = "top";
        public static string position_center = "center";
        public static string position_center_start = "center-start";
        public static string position_center_end = "center-end";
        public static string position_bottom = "bottom";
        public static string position_bottom_start = "bottom-start";
        public static string position_bottom_end = "bottom-end";

        public static string Toast(string title, string icon = "success", string position = "top-end", int timer = 1500)
        {
            //icon: 'success',
            return @"Swal.fire({
                              position: '{position}',
                              icon: '{icon}',
                              title: ' {title} ',
                              showConfirmButton: false,
                              timer: {timer}
                            })
                         ".Replace("{title}", title).Replace("{timer}", timer.ToString()).Replace("{icon}", icon).Replace("{position}", position);
        }
        public static string Modal(string title, string text, string icon = "success")
        {
            return @"Swal.fire({
                          icon: '{icon}',
                          title: '{title}',
                          text: '{text}!'
                        })
                      ".Replace("{title}", title).Replace("{text}", text).Replace("{icon}", icon);
        }




    }

}
