#pragma once
#include "arrayList.h"
#include "pointerList.h"

typedef PointerList List;
/// typedef ArrayList List;

List* merge(List* firstList, List* secondList);

List* mergeSort(List* list);