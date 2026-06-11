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

## Installation & Setup

To compile and launch the deployment installer for the translator utility, follow these steps:

1. Clone this repository to your local machine.
2. Open the project solution in **Visual Studio**.
3. Navigate to the `Setup` directory.
4. Open and run the `Setup.vdproj` file to launch the Visual Studio Installer framework and build/install the executable environment.

## Core Technical Features

* **Custom Tokenization & Parsing:** Iterates through variable-length string inputs to handle single-character boundaries dynamically.
* **Data Mapping:** Utilizes a systematic structural lookup (handling uppercase/lowercase variations) to accurately match the 26 English characters to their complex phonetic counterparts.
* **String Architecture:** Efficiently manages string concatenation and formatting to output structured, hyphen-delimited translations.

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
