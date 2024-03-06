export class MyAnimation {
    _name: string = "animation";
    _transform: Map<string, string> = new Map<string, string>();

    get Transform(): Map<string, string> {
        return this._transform;
    }

    set Name(name: string) {
        this._name = name;
    }

    get Name(): string {
        return this._name;
    }

    constructor() {
        this._transform.set("translateX", "0px");
        this._transform.set("translateY", "0px");
        this._transform.set("scaleX", "1");
        this._transform.set("scaleY", "1");
        this._transform.set("rotate", "0deg");
    }

    get ToString(): string {
        return `Animation '${this._name}'`;
    }
}