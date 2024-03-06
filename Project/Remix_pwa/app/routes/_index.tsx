import type { MetaFunction } from "@remix-run/node";
import Dropdown from "~/components/Dropdown";
import Nav from "~/components/Nav";

export const meta: MetaFunction = () => {
  return [
    { title: "Нет пока названия" },
    { name: "description", content: "Нет пока описания" }
  ];
};

export default function Index() {
  return (
    <body className="flex flex-col h-100 w-100">
      <Nav>
        {/* <Dropdown Header="Проект" DropdownMenu={
          
        }/> */}
      </Nav>
      <main>

      </main>
    </body>
  );
}
