import { HtmlElement } from "../interfaces/HtmlElement";
import { MyAnimation } from "./Animation";

export class Project {
    _title: string = "Безымянный";
    _elements: Array<HtmlElement> = new Array<HtmlElement>();
    _animations: Array<MyAnimation> = new Array<MyAnimation>();

    get Title(): string {
        return this._title;
    }

    get Elements(): Array<HtmlElement> {
        return this._elements;
    }

    get Animations(): Array<MyAnimation> {
        return this._animations;
    }

    set Title(name: string) {
        this._title = name;
    }

    set Elements(elements: Array<HtmlElement>) {
        this._elements = elements;
    }

    set Animations(animations: Array<MyAnimation>) {
        this._animations = animations;
    }
}