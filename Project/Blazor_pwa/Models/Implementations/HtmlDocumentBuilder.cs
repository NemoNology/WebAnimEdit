using Blazor_pwa.Models.Interfaces;

namespace Blazor_pwa.Models.Implementations
{
    public static class HtmlDocumentBuilder
    {
        public static string GetHeadWithTitle(string title) =>
            $@"
<head>
    <meta charset={"UTF-8"}
    <meta name={"viewport"} content={"width=device-width, initial-scale=1.0"}
    <meta http-equiv={"X-UA-Compatible"} content={"ie=edge"}
    <title>{title}</title>;
</head>";

        public static string BuildAnimation(Animation animation)
        {
            string res = $"@keyframes {animation.Name} {{\n\tto {{ ";
            string transformInfo = "";
            foreach ((string key, string value) in animation.Transform)
                transformInfo += $"{key}: {value}; ";
            if (animation.Transform.Count > 0)
                res += $"transform: {transformInfo}; ";
            res += $"}}\n}}";
            return res;
        }

        public static string BuildElement(HtmlElement element)
        {
            string res = $"<{HtmlElementsInfo.GetHtmlElementTagByType(element.Type)} ";
            foreach ((string key, string value) in element.Attributes)
                res += $"{key}: {value}; ";
            string styleInfo = "";
            foreach ((string key, string value) in element.Style)
                styleInfo += $"{key}: {value}; ";
            if (element.Style.Count > 0)
            {
                res += $"style=\"{styleInfo} ";
                if (element.Animation is not null)
                    res += $"animation-name: {element.Animation.Name} ";
                res += "\";";
            }
            return res;
        }

        public static string BuildProject(Project project) =>
            @$"<DOCKTYPE html>
<html lang=""en"">
    <style>
        {string.Join("\n\t", project.Animations.Select(anim => anim is null ? "" : BuildAnimation(anim)))}
    </style>
    {GetHeadWithTitle(project.Title)}
    <body>
        {string.Join("", project.Elements.Select(el => BuildElement(el) + "\n"))}
    </body>
</html>";
    }
}