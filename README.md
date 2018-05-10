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
|         [1.1 Purpose](#11-purpose)      |
|         [1.2 Project Scope](#12-project-scope)      |
|         [1.3 References](#13-references)      |
|         [**2. Overall Description**](#2-overall-description)        |
|         [2.1 Product Perspective](#21-product-perspective)     |
|         [2.2. User Classes and Characteristics](#22-user-classes-and-characteristics)      |
|         [2.3 Operating Environment](#23-operating-environment)       |
|         [**3. System Features**](#3-system-features)        |
|         [3.1 Key Analyzer](#31-key-analyzer)     |
|         [3.2 Chord Finder](#32-chord-finder)        |
|         [3.3. Scale Finder](#33-scale-finder)       |
|         [**4. External Interface Requirements**](#4-external-interface-requirements)        |
|         [4.1 User Interfaces](#41-user-interfaces)       |
|         [4.2 Home](#42-home)       |
|         [4.3 Key Analyzer](#43-key-analyzer)       |
|         [4.4 Scale Fninder](#44-scale-finder)       |
|         [4.5 Chord Finder](#45-chord-finder)       |
|         [4.6 Search](#46-search)       |
|         [**5. Quality Attributes**](#5-quality-attributes)       |
|         [5.1 Usability](#51-usability)      |
|         [5.2 Performance](#52-performance)       |
|         [**6. UML Diagrams**](#6-uml-diagrams)       |
|         [6.1 Use Case Diagram](#61-use-case-diagram)       |
|         [6.2 Component Diagram](#62-component-diagram)       |
|         [6.3 Class Diagram](#63-class-diagram)       |
|         [6.4 Entity Relationship Diagram](#64-entity-relationship-diagram)       |
| |


## 1. Introduction

This program is a mobile application designed as a music theory tool for the company Chromatic Method, which presents a unique and fresh way to learn music theory.

#### 1.1 Purpose

The product this SRS describes the requirements for is Chromatica, a mobile application by the company Chromatic Method. It is currently in development, and this document is for developers, project managers, and usability testers to learn about the program.

#### 1.2 Project Scope

Chromatica is a mobile app that allows the user to search and view the musical interrelationships between a given key, chord, or scale. It contains the algorithms that govern how chords and scales are built, and contains the systematic and detailed information of western music theory. Chromatica relates to both user and corporate goals. The end user will be music educators, students, and composers. This app assists in the teaching, learning, and creation of music, and as such is able to help the users meet their individual goals. It relates to the business objective of Chromatic Method in that it presents a third-party platform that music schools can use to supplement their curriculum.

#### 1.3 References

- [_Xamarin Forms_](https://developer.xamarin.com) _– Platform_
- [_Native UI_](https://developer.apple.com/design/) _– Design

## 2. Overall Description

This section describes the environment the application will run in, anticipated user classes, and an overview of the product.


#### 2.1 Product Perspective

This is a new product designed to fill a market need for comprehensive music theory systems in the private and public music education sectors. It will use a subscription-based business model, with a monthly charge per user. As an app tailored to the education world, it will be marketed towards the classroom as an extracurricular resource.

#### 2.2 User Classes and Characteristics

There are three primary user classes that are being anticipated to use this product. These classes are music educators, music students, and composers. Characteristics of the music educator include a current high-level knowledge of the ideas the app is based on. Because of this, they will use the program more as a way to show the result of an idea, rather than learn that concept themselves. The student will be coming in with limited or no knowledge, and as such will use the app as a way to get a result for something they cannot figure out themselves. The third class is composers, who will use the app as a resource to generate ideas and better visualize musical concepts. The favored user class is the teacher, as the goal is for the app to become a widespread extracurricular program in the music classroom.

#### 2.3 Operating Environment

The software will operate in an iOS and Android environment, on the current versions (iOS 11 and Android 8 &quot;Oreo&quot;) of both platforms. The geographical location of users will primarily be in the United States, although the universality of the musical language will allow it to be used in any country. The first iteration of the app will be in English however, although later versions will add more technical support. The application will operate entirely offline and as such there are no Internet network connectivity requirements beyond the initial installation.

## 3. System Features

The system features of the application are listed below

### 3.1 Key Analyzer

#### 3.1.1 Description

This feature allows the user to input a key and get a return of all the musical relationships within that key, including the major scale, a chord scale, and the modes in the key.

#### 3.1.2        Stimulus/Response Sequences

The user action that will stimulate the return is selecting a key from the homepage, which will show the major scale and chord scale in the key. It is the starting point for both the _Chord Finder_ and the _Scale Finder_, and will have functionality for the user to search within the 

### 3.2 Chord Finder

#### 3.2.1        Description

This feature allows the user to select any chord and get a return of the notes that comprise it and the scale it corresponds to.

#### 3.2.2        Stimulus/Response Sequences

The user action that will stimulate the return is navigating to the chord finder tab in the bottom navigation bar, and by selecting one of the chords that corresponds to the diatonic scale in the key. 

### 3.3 Scale Finder

#### 3.3.1        Description

This feature allows the user to select a scale and get a return of the scale and modes of it.

#### 3.3.2        Stimulus/Response Sequences

The user action that will stimulate the return is navigating to the scale finder tab at the bottom of the application, and selecting a scale or mode. This will return the notes in that scale for the key the user has selected. 

## 4. External Interface Requirements

This lays out information about the external user interface required by the system.

#### 4.1 User Interfaces

The homepage will be the entry point for the application, with all 12 keys shown. Once a key is selected, The user interface of this application will feature a standard navigation bar at the bottom of the screen with the following tabs: Key Analyzer, Scale Finder, and Chord Finder. The former will present an overview of the key with the major scale and diatonic triads, as well as a search function that will be added the next release. Both of the latter will present a listing of the chord and scale options, from which the user can select. 

#### 4.2 Home

This view is the first page presented to the user upon entering the app, and it presents all 12 keys as a starting point for the user. Each key can be entered, and the three primary views of key analyzer, scale finder, and chord finder are presented. This view also has an option in the top right to enter a search screen. The search function is not currently ready for production, but the interface is included in the prototype for the purpose of demonstration. There is an option to return to home from every view via a button in the upper left corner of the app, and the user can begin browsing another key if they wish. 

Homepage            |  Homepage Continued
:-------------------------:|:-------------------------:
![Home 1](https://i.imgur.com/pFcbhOv.png)  |  ![Home 2](https://i.imgur.com/3ZP5xsX.png)


#### 4.3 Key Analyzer

This view is the first thing presented to the user upon clicking a key. For example, if a user clicks on **C** from the homepage, the C Key Analyzer will present an overview showing the notes in the C major scale and all the diatonic triads in the key. It also presents a search bar that will enable the user to search all scales and chords in the key of C. This function is not production ready yet, but the interface element is included for the purpose of demonstration. There is also a navigation bar at the bottom of this view that shows the _Key Analyzer_ as the current page, and the option to navigate to the _Scale Finder_ or _Chord Finder_. 

Key Analyzer            |  Key Analyzer Search
:-------------------------:|:-------------------------:
![Home 1](https://i.imgur.com/dm1DD0f.png)  |  ![Home 2](https://i.imgur.com/YAtaQk1.png)

#### 4.4 Scale Finder

This view is the second option presented to the user in a given key. It can be navigated to by selecting a key from the homepage such as **C**, and tapping the second option in the bottom navigation bar. This view presents all of the scale options in the key, and as of right now the app offers 7 scales and thier related modes. Four of the scales are 7-note, two are 5-note, and one is 8-note. With thier relative modes, this gives the user a total of 46 scales to draw from, and more will be added as development continues. All the notes are generated by algorithms on the backend, and while just the note names are returned currently, eventually graphical notation and fretboard diagrams will be generated using the currenly available data structures. Each scale presents the option to go back to the scales page with a button in the upper left. 

Scale Finder           |  Scale Finder 2
:-------------------------:|:-------------------------:
![Scale 1](https://i.imgur.com/J0s7NO0.png)  |  ![Scale 2](https://i.imgur.com/sxdaoKa.png)

Scale Example 1           |  Scale Example 2
:-------------------------:|:-------------------------:
![Scale 3](https://i.imgur.com/93rUjKv.png)  |  ![Scale 4](https://i.imgur.com/ubyXxH0.png)

#### 4.5 Chord Finder

This view is the third option presented to the user in a given key, and can be navigated to by selecting a key from the homepage and tapping the third option in the bottom navigation bar. It presents all of the chordal options in the key, and the app currently offers five types of chords, with the chord that corresponds to each note in the diatonic scale. This gives the user 35 chords in each key, with more to be added as development continues and more features are added. As with the scales, all the chords are generated by code on the backend, and notation and fretboard diagrams will be added. 

Chord Finder 1           |  Chord Finder 2
:-------------------------:|:-------------------------:
![Chord 1](https://i.imgur.com/fRZm6CQ.png)  |  ![Chord 2](https://i.imgur.com/WhURyZw.png)

Chord Example 1           |  Chord Example 2
:-------------------------:|:-------------------------:
![Chord 3](https://i.imgur.com/r8gO3Tr.png)  |  ![Chord 4](https://i.imgur.com/JzToVb5.png)

#### 4.6 Search

The search function is not currently production ready, but the UI is included for the purpose of what will be possible as the app continues production. This view is accessed from the homepage by clicking the button in the top right. The view simply presents a search bar and keyboard, and will enable to user to search all the scales and chords throughout all of the keys. This is a function that is used to find a particular chord or scale quickly, though some users will prefer to explore the keys by tapping through the various pages instead. 

Search 1           |  Search 2
:-------------------------:|:-------------------------:
![Search 1](https://i.imgur.com/KkmpQL2.png)  |  ![Search 2](https://i.imgur.com/MByvIa5.png)


## 5. Quality Attributes

#### 5.1 Usability

This software will be user-friendly in the logical organization of the user interface, easy to learn and search for needed information, and aesthetically pleasing based on the native user interface of the platform. 

#### 5.2 Performance

This application is relatively lightweight, and as such will perform well even on older devices. It does not require Internet accessibility and does not interact with other applications or have any unique dependencies.

## 6. UML Diagrams 

This section contains UML diagrams describing various aspects of The Chromatic Method
application, and contains the following diagrams. The use case diagram illustrates the interaction of
actors with the application; the component diagram shows the interaction of the components with each
other, the class diagram shows the interrelationship of classes and their functions, and the entity
relationship diagram illustrates the relationship between the various entities of the application. Each
section will have both the diagram and a paragraph describing its contents.

#### 6.1 Use Case Diagram

The diagram below presents the three user classes that interact with the system: Students, Educators,
and Composers, and a system ‘user’ the Messaging Handler. The student exclusively interacts with a
student login page, and can use a built-in messaging function to communicate with an educator. The
composer, which is a non-registered user of the application, interacts with the three primary functions
within the application, the key analyzer, the chord finder, and the scale finder. This user can also save
ideas he or she draws from the scales and chords they generate. The educator interacts with a teacher
login, can message their students, view student activity, and set up assignments for them to perform.
Both the students and teachers can also access the three main functions of the application.

|   |  |
| ------------- | ------------- |
| Use Case    | 1. The_Chromatic_Method __history__: created 3/6/18 by Jared Forth | |
| Description    | Generates the musical relationships ina key, finds scales and chords based on user selection  |
| Actors    | Educator (Primary), Student, Composers  |
| Assumptions    | Generative algorithms can return all musical relationships in a given key  |
| Issues    | Working on adding search fuction, standard notation graphics  |

##### Steps

* User opens app and sees homepage
* User selects a key
* Can perform one of the following
actions:
  - Search from key analyzer (coming soon)
  - View scales and modes by accessing scale finder
  - View chords by accessing chord finder
* Return home
* Select new key _or_
* Exit application

![Use Case](https://i.imgur.com/q2NEFg7.png)

#### 6.2 Component Diagram

The component diagram illustrates the interaction of components and is structured based on the user
interface, functions that can be used, and the infrastructure/ logic behind those functions. The three user
interface screens are the user login screen, which students and teachers can use to login and which can
optionally be skipped by normal users. The key analyzer screen is the primary home interface on the
application, and the scale/chord finder is the secondary interface that can be navigated to. The user
management function regulates the login interface, the analysis function that of the key analyzer, and
the chord and scale finder functions for the corresponding finder interface. User logic regulates the
management of users and controls how they are allowed to interact with each other. The analyzer and
chord and scale finder logic uses slightly different algorithms to return information based on the user
input.

![Component](https://i.imgur.com/KtxEQs1.png)

#### 6.3 Class Diagram 

The class diagram presents the classes in the application logic, and has the Composer, Educator, and
Student, which are particular instances of the general class User. The Login class allows students and
educators to login and view details specific to their account. The LoginPage class allows the user to
send a message or view/assign a practice, depending on the type of account the user has. The
StudentMenu and TeacherMenu classes regulate the function of these actions. The Composer class
regulates the actions of a user that is not logged in to the application. The three primary logical functions
of the application are found in the Analyzer, ChordFinder, and ScaleFinder classes, which contain the
logic for the function of the application. The algorithms that return what the user is looking for are
contained in these classes. The SaveIdea class allows the user to save snippets they have generated,
and the three primary classes are accessible by all users.

![Class](https://i.imgur.com/K8AcwIU.png)

#### 6.4 Entity Relationship Diagram

The entity relationship diagram presents the relationship between entities of the application and the ratio
by which they can interact with one another. Many users can access any of the functions at any time,
and this applies to all users. The particular instance of user, one educator, can teach many students, but
each student only relates to one teacher. Many composers can save many ideas, and both educators
and students can access all of the functions.

![Entity - relationship](https://i.imgur.com/ZeRQGXa.png)
