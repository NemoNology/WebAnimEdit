import { HtmlElement } from "../interfaces/HtmlElement";
import { MyAnimation } from "./Animation";

export class HtmlDocumentBuilder {
    BuildHead(title: string): string {
        return `<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>${title}</title>
</head>`;
    }

    BuildAnimation(animation: MyAnimation): string {
        let res = `@keyframes ${animation.Name} {\nto {`;
        let transformInfo: string = "";
        animation.Transform.forEach((value, key) => {
            transformInfo += `${key}: ${value}; `
        });
        if (animation.Transform.size > 0) {
            res += `transform: ${transformInfo} ;`;
        }
        res += `}\n}\n`;
        return res;
    }

    BuildElement(element: HtmlElement): string {
        let res = `<${element.Name} `;
        element.Parameters.forEach((value, key) => {
            res += `${key}="${value}" `;
        });
        let style_info: string = "";
        element.Style.forEach((value, key) => {
            style_info += `${key}: ${value}; `;
        });
        if (style_info.length > 0) {
            res += `style="${style_info} `;
            if (element.Animation !== null) {
                res += `animation-name: ${element.Animation.Name} `;
            }
            res += '";';
        }
        return res + `/>\n`;
    }

    Build(title: string, elements: Array<HtmlElement>, animations: Array<MyAnimation>): string {
        return `<!DOCTYPE html>
<html lang="en">
<style>
    ${animations.map(a => this.BuildAnimation(a))}
</style>
${this.BuildHead(title)}
<body>
    ${elements.map(e => this.BuildElement(e))}
</body>
</html>`
    }
}