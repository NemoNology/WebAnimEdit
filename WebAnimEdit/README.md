# WebAnimEdit / РедВебМульт

## Описание

Онлайн редактор мультипликации на основе HTML5.

## Архитектура проекта

### Бизнес-логика

```mermaid
---
title: Бизнес-логика
---
flowchart TD
    AnimationObject[Объект анимации]
    Project[Проект]
    AnimationPlayer[Проигрыватель анимации]
    Application["Приложение (Главный контроллер)"]
    AnimationFrame["Кадр анимации"]
    AnimationClip["Отрезок анимации"]
    
    Application --> Project
    Application --> AnimationPlayer
    
    Project --> AnimationObject
    
    AnimationPlayer --> AnimationClip
    AnimationClip --> AnimationFrame
```

### UI-компоненты

```mermaid
---
title: UI-компоненты
---
flowchart LR
    AnimationObjectPropertiesEditor[Редактор объекта анимации]
    ProjectEditor[Редактор проекта]
    AnimationPlayer[Проигрыватель анимации]
    AnimationFrame["Редактор кадра анимации"]
```

```mermaid
---
title: Анимация
---
flowchart TD
    AnimationPlayer[Проигрыватель анимации]
    Animation[Анимация]
    AnimationClip[Отрезок анимации]
    AnimationFrame[Кадр анимации]
    
    AnimationPlayer --> Play/Stop
    AnimationPlayer --> MoveToFrame
    AnimationPlayer --> Update
    
    
```

## Планы

### Оптимизация

- кеширование кадров

## Дополнительные материалы

[Ссылка на оставшуюся часть ВКР](https://github.com/NemoNology/Degree-work).
