import { FC, ReactNode } from "react";
import Button from "./Button";

export type MyDropdownProps = {
    Header: string,
    ID: string,
    DropdownMenu: ReactNode,
};

const Dropdown: FC<MyDropdownProps> = ({ Header, ID, DropdownMenu }) => {
    const fullID: string = "dd_tb_" + ID;
    return (
        <>
            <Button ID={fullID} Header={Header} DataDropdownToggle="dropdown" />
            <div id="dropdown" className="hidden">
                <ul aria-labelledby={fullID}>
                    {DropdownMenu}
                </ul>
            </div>
        </>
    );
};

export default Dropdown;