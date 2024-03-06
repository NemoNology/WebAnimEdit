import { FC, ReactNode } from "react";

export type ButtonProps = {
    Header?: string;
    onClick?: Function;
}

const Button: FC<ButtonProps> = ({ Header, onClick }) => {
    return (
        <button
            type="button"
            className="bg-light rounded-lg p-2 font-medium"
            onClick={() => onClick && onClick()}
        >
            {Header}
        </button>
    );
};

export default Button;