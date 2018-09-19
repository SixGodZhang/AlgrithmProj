# 一些简单算法的源码
---

## class Fabonacci
列举了斐波那契数列的两种算法，并且比较了其性能
总结:递归是从大到小,有助于我们细分问题,但是对计算机而言,递归会增加许多重复的计算

## class LongestSubstring
求两个字符串的最大子串
总结:将两个字符串的比较结果映射到一张二维数组表上,并在二维数组表的对应位置上计算其重复元素的个数

## class BinarySearch
二分法
总结:使用二分法的前提是一组有序的数列

## class SortMethods.BubbleSort(int[] arr)
冒泡排序
总结:冒泡排序是每一个数和剩下所有的数进行比较

## class SortMethods.SelectSort(int[] arr)
选择排序
总结:每次选取最大的数放在行尾

## class SortMethods.QuickSort(int[] arr,int begin, int end)
快速排序
总结:D&C 分而治之，由上至下