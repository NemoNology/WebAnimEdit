# Диаграмма классов

```mermaid
classDiagram
    direction LR
    class AbstractHtmlElement{
        +Type: HtmlElementType
    }
    class ObjectWithBlocksOfProperties{
        +BlocksOfProperties: BlockOfProperties[]
    }
    class BlockOfProperties{
        +Type: BlockOfPropertiesType
        // Property is name and value
        +Properties: Dictionary~string, string~
    }
    class Animation{
        +Name: string
        +KeyFrames: List~KeyFrame~
    }
    class KeyFrame{
        +Selector: double
    }
    class Project{
        +HtmlElement: AbstractHtmlElement
        +Animations" List~Animation~
    }
    class HtmlElementType{
        <<enum>>
        None
        Html
        Style        
        Head
        Title
        Meta
        Link
        Body
        Division
        Image
        Script
    }
    class BlockOfPropertiesType{
        <<enum>>
        Attributes
        Style
        Classes
        Animations
        EventsHandlers
    }
    class HtmlElementsInfo{
        +GetHtmlElementNameByType(HtmlElementType) string$
        +GetHtmlElementTagByType(HtmlElementType) string$
        +GetHtmlElementBaseAttributesBlockByType(HtmlElementType) PropertiesBlock$
        +BaseStyleBlock PropertiesBlock$
        +HtmlElementsEventsList string[]$
    }
    class HtmlDocumentBuilder{
        +GetDocumentHeadWithSpecifiedTitle(string) string$
        +BuildAnimation(Animation) string$
        +BuildHtmlElement(Animation) string$
        +BuildProject(Project) string$
    }
    ObjectWithBlocksOfProperties<|--AbstractHtmlElement
    ObjectWithBlocksOfProperties<|--KeyFrame
    ObjectWithBlocksOfProperties*--BlockOfProperties
    BlockOfProperties*--BlockOfPropertiesType
    Animation*--KeyFrame
    AbstractHtmlElement*--HtmlElementType
    Project*--AbstractHtmlElement
    Project*--Animation
```
