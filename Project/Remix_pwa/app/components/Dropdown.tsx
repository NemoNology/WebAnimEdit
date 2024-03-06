import { FC, ReactNode } from "react";
import {
    TEDropdown,
    TEDropdownToggle,
    TERipple,
} from "tw-elements-react";

export type DropdownProps = {
    Header: string,
    DropdownMenu: ReactNode,
};

const Dropdown: FC<DropdownProps> = ({ Header, DropdownMenu }) => {
    return (
        <TEDropdown>
            <TERipple>
                <TEDropdownToggle>
                    {Header}
                </TEDropdownToggle>
            </TERipple>
            {DropdownMenu}
        </TEDropdown>
    );
};

export default Dropdown;