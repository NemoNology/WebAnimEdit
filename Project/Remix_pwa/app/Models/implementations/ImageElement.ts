import { HtmlElement } from "../interfaces/HtmlElement";

export class ImageElement extends HtmlElement {
    override get Name(): string { return "img"; }

    constructor(src: string = "put your image url here", alt: string = "put alt text here") {
        super();
        this._attributes.set("src", src);
        this._attributes.set("alt", alt);
    }
}