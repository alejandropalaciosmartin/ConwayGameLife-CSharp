# Conway's Game of Life in C#

This repository hosts an implementation of Conway's Game of Life in C#, a classic cellular automaton. It was developed as a practical exercise during my studies, following the provided guidelines:

## Exercise Requirements
In this practice, the task was to program the famous Conway's Game of Life in a console application, adhering to the following guidelines:

1. Create a 50x50 two-dimensional matrix.
2. At the start, randomly set each cell in the matrix to be alive or dead (with a 50% probability).
3. The iterations are infinite, with a 250-millisecond pause between each.
4. In each iteration, apply the rules of Conway's Game of Life to the created matrix.

## Rules of the Game
The universe of Conway's Game of Life consists of an infinite two-dimensional orthogonal grid of square cells, each of which can be in one of two possible states: alive or dead. Each cell interacts with its eight neighbors, which are the cells that are horizontally, vertically, or diagonally adjacent.

The rules can be summarized as follows:
- Any live cell with two or three live neighbors survives.
- Any dead cell with three live neighbors becomes a live cell.
- All other live cells die, and all other dead cells remain dead.

A new generation begins when all cells have been updated once. This means the next generation starts from scratch, with no memory of previous generations.

## Features
This repository includes two different programs:
1. A random cell initialization program that creates a 100x100 matrix and runs it with random cell states.
2. A glider simulation program that showcases a glider moving across the screen.

## Getting Started
1. Clone this repository.
2. Build and run the program in your preferred C# development environment.
3. Explore and modify the code as needed.
4. Enjoy experimenting with Conway's Game of Life and feel free to contribute to make it even more interesting!

Feel free to provide feedback, suggestions, or contributions to enhance the code or address any issues. Your input is always welcome to improve this implementation.

