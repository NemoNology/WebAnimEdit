namespace WebAnimEdit.Models.Implementations
{
    public static class HtmlElementExtentions
    {
        /// <summary>
        /// Remove first html element from html element children deeply, searching in all children 
        /// </summary>
        /// <param name="root">Html element from which another element will be removed</param>
        /// <param name="element">Html element that will be removed</param>
        public static void DeepRemoveFirstHtmlElement(this HtmlElement root, HtmlElement element)
        {
            if (root.Children.Count == 0)
                return;

            Queue<HashSet<HtmlElement>> buffer = new(root.Children.Count);
            buffer.Enqueue(root.Children);
            while (buffer.Count > 0)
            {
                var setBuffer = buffer.Dequeue();

                if (setBuffer.Contains(element))
                {
                    setBuffer.Remove(element);
                    return;
                }

                foreach (var el in setBuffer)
                {
                    if (el.Children.Count > 0)
                    {
                        buffer.Enqueue(el.Children);
                    }
                }
            }
        }
    }
}