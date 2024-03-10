import type { MetaFunction } from "@remix-run/node";
import Nav from "~/components/Nav";
import Button from "~/components/Button";
import Main from "~/components/Main";
import PropertyEditor from "~/components/PropertyEditor";
import { Project } from "~/Models/implementations/Project";
import { HtmlDocumentBuilder } from "~/Models/implementations/HtmlDocumentBuilder";
import ProjectTree from "~/components/ProjectTree";

export const meta: MetaFunction = () => {
  return [
    { title: "Нет пока названия" },
    { name: "description", content: "Нет пока описания" }
  ];
};

export default function Index() {
  const project: Project = new Project();
  const hdb: HtmlDocumentBuilder = new HtmlDocumentBuilder();

  return (
    <body className="flex flex-col h-full">
      <Nav Children={
        <>
          <Button Header="Новый" />
          <Button Header="Экспорт" />
        </>
      } />
      <Main Children={
        <>
          <div className="flex flex-col p-2 flex-grow bg-secondary justify-center">
            <PropertyEditor PropertyName="Заголовок"
              PropertyValue={project.Title}
              onChange={(value: any) => {
                project.Title = value;
              }} />
            <ProjectTree Project={project} />
          </div>
          <div className="flex justify-between" style={{ flexGrow: 3.5 }}>
            <Button Header="Log build"
              onClick={() => console.log(hdb.Build(project.Title, project.Elements, project.Animations))} />
          </div>
          <div className="flex flex-grow bg-secondary justify-center">

          </div>
        </>
      } />
    </body>
  );
}
