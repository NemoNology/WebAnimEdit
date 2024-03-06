import { FC } from 'react';
import { CommonProps } from './CommonProps';

const Nav: FC<CommonProps> = ({ Children }) => {
    return (
        <nav className="bg-primary p-2 flex gap-2">
            {Children}
        </nav>
    );
};

export default Nav;