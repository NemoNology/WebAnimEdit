import { HtmlElement } from "../interfaces/HtmlElement";

export class DivElement extends HtmlElement {
    override get Name(): string { return "div"; }

    constructor() {
        super();
        this._style.set("width", "100px");
        this._style.set("height", "100px");
    }
}