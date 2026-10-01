# MathEngine.Core

An open-source, zero-dependency C# class library designed for manual mathematical computations, including exponentiation, roots, and logarithms—built without relying on framework primitives like `Math.Pow` or `Math.Sqrt`.

---

## Overview

`MathEngine.Core` is an R&D-focused class library built to explore low-level numerical computing, algorithm design, and software architecture in .NET. By implementing mathematical functions from scratch using basic arithmetic operations, this library prioritizes algorithmic transparency and execution efficiency.

---

## Development Roadmap

| Phase | Module | Scope | Status |
| :--- | :--- | :--- | :--- |
| **V.0.1** | Exponents & Basic Roots | Integer powers ($a^b$, $a^0$, $a^{-b}$) and manual square/cube roots | 🟢 Released |
| V0.2.0 | Self-Sufficiency & Roots | Numerical root algorithms (Newton-Raphson, $n$-th root) without framework dependencies | 🟡 In Progress |

---

## Architecture

This solution follows a decoupled design pattern:
- **`MathEngine.Core` (Class Library):** Contains all mathematical logic, guard clauses, and calculation services.
- **`MathEngine.Runner` (Console App):** Serves as an interactive harness for manual testing and verification.

---

## License

This project is licensed under the MIT License - free for personal and commercial use.
