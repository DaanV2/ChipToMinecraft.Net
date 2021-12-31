# Chip To Minecraft.Net

- [Chip To Minecraft.Net](#chip-to-minecraftnet)
  - [Block pallete](#block-pallete)
  - [API Usage](#api-usage)
  - [Manually manipulation](#manually-manipulation)

## Block pallete

[read here](./documentation/block_pallete.md)

## API Usage

```csharp
//Load
Project.Project Data = Chip.Project.ProjectLoader.Load(ProjectFilepath);

Data.Process();
```


## Manually manipulation


```csharp
using Chip.Minecraft;

//Opens the world
var World = WorldFactory.Open(Folder, Options);

var area = new Box(0, 0, 0, 25, 25, 25);

//For each subchunk in the area
World.ForEach((sc) => { ... }, area);

World.Fill(Box, BlockFactory.Blocks.Air);
World.Fill(Box, new Block("minecraft:iron_block"));
```
