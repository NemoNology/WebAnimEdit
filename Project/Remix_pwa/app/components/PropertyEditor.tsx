import { FC, useState } from "react"

export type PropertyEditorProps = {
    PropertyName: string,
    PropertyValue: any,
    onChange: (value: any) => void,
}

const PropertyEditor: FC<PropertyEditorProps> = ({ PropertyName, PropertyValue, onChange }) => {
    const [inputValue, setInputValue] = useState(PropertyValue);

    const handleChange = (event: React.ChangeEvent<HTMLInputElement>) => {
        const newValue = event.target.value;
        setInputValue(newValue);
        onChange(newValue);
    }

    return (
        <div className="flex p-2 gap-2 content-center">
            {`${PropertyName}:`}
            <input style={{ height: "fit-content" }} name="{PropertyName}"
                type="text" value={inputValue}
                onInput={handleChange}
            />
        </div>
    )
}

export default PropertyEditor;