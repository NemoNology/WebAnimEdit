import { MyAnimation } from "../implementations/Animation";

export abstract class HtmlElement {
    _animation: MyAnimation | null = null;
    _style: Map<string, string> = new Map<string, string>();
    _attributes: Map<string, string> = new Map<string, string>();

    get Animation(): MyAnimation | null {
        return this._animation;
    }

    set Animation(animation: MyAnimation | null) {
        this._animation = animation;
    }

    get Parameters(): Map<string, string> {
        return this._attributes;
    }

    get Style(): Map<string, string> {
        return this._style;
    }

    abstract get Name(): string;

    constructor() {
        this._style.set("left", "0px");
        this._style.set("top", "0px");
        this._style.set("position", "absolute");
        this._style.set("z-index", "0");
        this._style.set("animation-duration", "1s");
    }

    get ToString(): string {
        return `Html element '${this.Name}'`;
    }
}