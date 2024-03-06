import { FC } from "react";
import { CommonProps } from "./CommonProps";

const Main: FC<CommonProps> = ({ Children }) => {
    return (
        <main className="flex flex-grow">
            {Children}
        </main>
    );
}

export default Main;