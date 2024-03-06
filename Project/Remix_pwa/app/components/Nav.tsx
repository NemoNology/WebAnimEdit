import { FC } from 'react';
import { CommonProps } from './CommonProps';

const Nav: FC<CommonProps> = ({ Children: children }) => {
    return (
        <nav className="bg-primary p-2 flex">
            {children}
        </nav>
    );
};

export default Nav;