# Software Requirements Specification
## for
# The Chromatic Method

**Prepared by Jared Forth**

**Fort Hays State University**

**2/19/2018**

## Table of Contents

| Table of Contents        |
| --- |
|         [**1. Introduction**  ](#1-introduction)     |
|         1.1 Purpose      |
|         1.2 Project Scope      |
|         1.3 References       |
|         [**2. Overall Description**](#2-overall-description)        |
|         2.1 Product Perspective     |
|         2.2. User Classes and Characteristics      |
|         2.3 Operating Environment       |
|         [**3. System Features**](#3-system-features)        |
|         3.1 Key Analyzer     |
|         3.2 Chord Finder        |
|         3.3. Scale Finder       |
|         [**4. External Interface Requirements**](#4-external-interface-requirements)        |
|         4.1 User Interfaces       |
|         [**5. Quality Attributes**](#5-quality-attributes)       |
|         5.1 Usability      |
|         5.2 Performance       |
| |



## 1. Introduction

This program is a mobile application designed as a music theory tool for the company Chromatic Method, which presents a unique and fresh way to learn music theory.

**1.1 Purpose**

The product this SRS describes the requirements for is Chromatica, a mobile application by the company Chromatic Method. It is currently in development, and this document is for developers, project managers, and usability testers to learn about the program.

understanding and describing their business and revenue model;

**1.2 Project Scope**

Chromatica is a mobile app that allows the user to search and view the musical interrelationships between a given key, chord, or scale. It contains the algorithms that govern how chords and scales are built, and contains the systematic and detailed information of western music theory. Chromatica relates to both user and corporate goals. The end user will be music educators, students, and composers. This app assists in the teaching, learning, and creation of music, and as such is able to help the users meet their individual goals. It relates to the business objective of Chromatic Method in that it presents a third-party platform that music schools can use to supplement their curriculum.

**1.3 References**

- [_Xamarin Forms_](https://developer.xamarin.com) _– Platform_
- [_Material Design_](https://material.io/guidelines/) _– Design language_

## 2. Overall Description

This section describes the environment the application will run in, anticipated user classes, and an overview of the product.


**2.1 Product Perspective**

This is a new product designed to fill a market need for comprehensive music theory systems in the private and public music education sectors. It will use a subscription-based business model, with a monthly charge per user. As an app tailored to the education world, it will be marketed towards the classroom as an extracurricular resource.

**2.2 User Classes and Characteristics**

There are three primary user classes that are being anticipated to use this product. These classes are music educators, music students, and composers. Characteristics of the music educator include a current high-level knowledge of the ideas the app is based on. Because of this, they will use the program more as a way to show the result of an idea, rather than learn that concept themselves. The student will be coming in with limited or no knowledge, and as such will use the app as a way to get a result for something they cannot figure out themselves. The third class is composers, who will use the app as a resource to generate ideas and better visualize musical concepts. The favored user class is the teacher, as the goal is for the app to become a widespread extracurricular program in the music classroom.

**2.3 Operating Environment**

The software will operate in an iOS and Android environment, on the current versions (iOS 11 and Android 8 &quot;Oreo&quot;) of both platforms. The geographical location of users will primarily be in the United States, although the universality of the musical language will allow it to be used in any country. The first iteration of the app will be in English however, although later versions will add more technical support. The application will operate entirely offline and as such there are no Internet network connectivity requirements beyond the initial installation.

## 3. System Features

The system features of the application are listed below

### 3.1 Key Analyzer

**3.1.1 Description**

This feature allows the user to input a key and get a return of all the musical relationships within that key, including the major scale, a chord scale, and the modes in the key.

**3.1.2        Stimulus/Response Sequences**

The user action that will stimulate the return is navigating to the key analyzer tab at the bottom of the application, taping in the text entry input bar, and imputing a key in the string: &#39;C,D,E,F,G,A,B&#39; with an optional sharp(#) or flat(b) attached. This will return the major scale, modes, and chords in that key.

### 3.2 Chord Finder

**3.2.1        Description**

This feature allows the user to enter any chord and get a return of the notes that comprise it and the scale it corresponds to.

**3.2.2        Stimulus/Response Sequences**

The user action that will stimulate the return is navigating to the chord finder tab at the bottom of the application, taping in the text entry input bar, and imputing a chord in the string: &#39;C,D,E,F,G,A,B&#39; with an optional sharp(#) or flat(b) attached. They can also attach one of the string: &#39;7,maj7,m7,9,maj9,m9,sus2,sus4,11,13, diminished, augmented&#39;. This will return the notes associated with the inputted chord.

### 3.3 Scale Finder

**3.3.1        Description**

This feature allows the user to input a scale and get a return of the scale and modes of it.

**3.3.2        Stimulus/Response Sequences**

The user action that will stimulate the return is navigating to the scale finder tab at the bottom of the application, taping in the text entry input bar, and imputing a key in the string: &#39;C,D,E,F,G,A,B&#39; with an optional sharp(#) or flat(b) attached. This will return the notes of the key and the modes associated with it.

## 4. External Interface Requirements

This lays out information about the external user interface required by the system.

**4.1 User Interfaces**

The user interface of this application will feature a standard navigation bar at the bottom of the screen with the following tabs: Key Analyzer, Chord Finder, Scale Finder, About. Each of the first three will contain a brief description of what the tool does, and an input box for the user to enter their search query into. One the user enters their input, the subsequent screen will have a the name of the chord, key, or scale, a diagram of the musical relationship of that element to the rest of the key, and an image of the notation.

## 5. Quality Attributes

**5.1 Usability**

This software will be user-friendly in the logical organization of the user interface, easy to learn and search for needed information, and aesthetically pleasing based on Google&#39;s Material Design language

**5.2 Performance**

This application is relatively lightweight, and as such will perform well even on older devices. It does not require Internet accessibility and does not interact with other applications or have any unique dependencies.
