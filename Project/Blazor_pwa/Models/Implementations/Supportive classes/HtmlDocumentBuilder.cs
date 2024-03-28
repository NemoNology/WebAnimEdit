using Blazor_pwa.Models.Interfaces;

namespace Blazor_pwa.Models.Implementations
{
    public static class HtmlDocumentBuilder
    {
        public static string Head =>
            $@"<head>
    <meta charset={"UTF-8"}
    <meta name={"viewport"} content={"width=device-width, initial-scale=1.0"}
    <meta http-equiv={"X-UA-Compatible"} content={"ie=edge"}
    <title>Без названия</title>;
</head>";

        public static string BuildAnimation(Dictionary<string, string> animation, int number)
        {
            if (animation.Count < 1)
                return "";
            string res = $"@keyframes animation{number} {{\nto {{ ";
            foreach ((string key, string value) in animation)
                res += $"{key}: {value};\n";
            res += "}\n}";
            return res;
        }

        public static string BuildElement(HtmlElement element, int number)
        {
            string res = $"<{HtmlElementsInfo.GetHtmlElementTagByType(element.Type)}";
            if (element.Attributes.Count > 0)
                foreach ((string key, string value) in element.Attributes)
                    res += $" {key}=\"{value}\"";
            if (element.Style.Count > 0)
            {
                res += " style=\"";
                foreach ((string key, string value) in element.Style)
                    res += $"{key}: {value}; ";
                if (element.AnimationStyle.Count > 0)
                    res += $"animation-name: animation{number};";
                res += "\"";
            }

            return res + " />";
        }

        public static string BuildProject(Project project, bool isFullDocument = false)
        {
            var animations = "";
            var elements = "";
            var counter = 0;

            // Getting animations and elements as strings
            foreach (HtmlElement el in project.Elements)
            {
                if (el.AnimationStyle.Count > 0)
                    animations += BuildAnimation(el.AnimationStyle, counter) + "\n";
                elements += $"\t{BuildElement(el, counter)}\n";
                counter++;
            }
            // Building html with html document tag and head
            var res = isFullDocument ? $"<!DOCKTYPE html>\n<html lang=\"en\">\n{Head}\n" : "";
            // Adding animations in style element
            if (animations.Length > 0)
                res += $"<style>\n{animations}</style>\n";
            // Adding body
            res += "<body>\n";
            // Adding elements in body element
            if (elements.Length > 0)
                res += $"{elements}";
            // Closing body and html tags
            res += "</body>";
            if (isFullDocument)
                res += "\n</html>";

            return res;
        }
    }
}