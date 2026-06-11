# Drakohnon Language Translator

A lightweight desktop utility written in C# that tokenizes, maps, and translates standard English text into a custom, phonetic Draconic fictional language ("Drakohnon"). 

---

## Overview

This project was built to explore character-by-character string manipulation, custom data mapping, and parsing logic. The system ingests an English string, processes each character dynamically, and cross-references it with a defined linguistic mapping table to output the structured, phonetic equivalent of the language.

### Translation Logic Example

When parsing the input `Kasen`, the translator isolates each letter and maps it to its designated phonetic component:

* **K** ➔ `kE`
* **a** ➔ `aw`
* **s** ➔ `sE`
* **e** ➔ `Eth`
* **n** ➔ `Nz`
* **Result:** `kE-aw-sE-Eth-Nz = kEawsEEthNz`

---

## Installation & Quick Start

Running the application is entirely seamless and requires no complex setup configurations:

1. Navigate to the **[Releases](https://github.com/KasenFudge/DrakohnonLanguageTranslator/releases)** section of this repository.
2. Download the standalone `DrakohnonLanguageTranslator.exe` binary from the latest release assets.
3. Double-click the downloaded executable to launch and interact with the translator utility instantly.

---

## Linguistic Blueprint

| English Letter | Phonetic Spelling | Audio Approximation Example |
| -------------- | ----------------- | --------------------------- |
| **A**          | aw                | dr-**aw**                   |
| **B**          | Bah               | **Bo**-mb                   |
| **C**          | crE               | **Cree**-d                  |
| **D**          | Dro               | **Dro**-ne                  |
| **E**          | Eth               | **Ey**th                    |
| **F**          | frA               | **Fray**                    |
| **G**          | Gaw               | **Go**-d                    |
| **H**          | Hu                | **Hue**                     |
| **I**          | eI                | **I**                       |
| **J**          | Jer               | **Jer**-k                   |
| **K**          | kE                | **Key**                     |
| **L**          | Lo                | **Lo**-w                    |
| **M**          | Mc                | **Mick**                    |
| **N**          | Nz                | **Nez**                     |
| **O**          | Or                | **Or**                      |
| **P**          | Per               | **Per**                     |
| **Q**          | Qu                | **Cue**                     |
| **R**          | RR                | **Rr**                      |
| **S**          | sE                | **See**                     |
| **T**          | Ts                | **Tis**                     |
| **U**          | Oth               | **Uth**-er                  |
| **V**          | Vr                | **Ver**-y                   |
| **W**          | wI                | **Why**                     |
| **X**          | Esk               | T-**isk**                   |
| **Y**          | Uo                | **You**                     |
| **Z**          | Zst               | **Z**-i-**st**              |

---

## Tech Stack

* **Language:** C#
* **Framework:** .NET Core / .NET Framework
* **Environment:** Console Application / IDE (Visual Studio)
