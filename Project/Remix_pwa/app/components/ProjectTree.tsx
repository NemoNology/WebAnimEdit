import { Project } from "~/Models/implementations/Project"
import Button from "./Button";
import { FC, useState } from "react";
import { MyAnimation } from "~/Models/implementations/Animation";
import { DivElement } from "~/Models/implementations/DivElement";
import { ImageElement } from "~/Models/implementations/ImageElement";

export type PropertyEditorProps = {
    Project: Project
}

const ProjectTree: FC<PropertyEditorProps> = ({ Project }) => {
    const [project, setState] = useState(Project);

    return (
        <div className="p-2 flex flex-col bg-light flex-grow w-fit">
            <div className="flex bg-accent p-2 justify-around w-fit">
                <Button Header="+ div" onClick={() => {
                    setState((state) => {
                        state.Elements.push(new DivElement());
                        return state;
                    });
                }} />
                <Button Header="+ img" onClick={() => {
                    setState((state) => {
                        state.Elements.push(new ImageElement());
                        return state;
                    });
                }} />
                <Button Header="+ anim" onClick={() => {
                    setState((state) => {
                        state.Animations.push(new MyAnimation());
                        return state;
                    });
                }} />
            </div>
            <div className="p-2 w-full flex-grow">
                {
                    project.Elements.map((value, index) => (
                        <div key={index}>
                            {value.Name}
                        </div>
                    ))
                }
                {/* {project.Elements.map((value, index) =>
                    <div className="flex p-1">
                        {value.Name}
                        <Button Header="x" onClick={() => {
                            setState((state) => {
                                let newState = state;
                                newState.Elements.splice(index, 1);
                                return newState;
                            });
                        }} />
                    </div>)}
                {project.Animations.map((value, index) =>
                    <div className="flex p-1">
                        {value.Name}
                        <Button Header="x" onClick={() => {
                            setState((state) => {
                                let newState = state;
                                project.Animations.splice(index, 1);
                                return newState;
                            });
                        }} />
                    </div>)} */}
            </div>
        </div>
    );
}

export default ProjectTree;