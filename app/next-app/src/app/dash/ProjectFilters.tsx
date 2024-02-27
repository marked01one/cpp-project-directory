'use client'

import { Card, Sidebar } from 'flowbite-react'
import React from 'react'
import FilterMajor from './filters/FilterMajor'
import { FaGraduationCap } from 'react-icons/fa6'
import { BsFilterRight } from 'react-icons/bs' 
import { FaMoneyBill1 } from 'react-icons/fa6'

export default function ProjectFilters() {
  const iconStyles = {
    display: 'inline',
    marginRight: '0.5rem'
  };

  return (
    <Sidebar aria-label='Filter and Sorting' className='container h-auto w-full my-2 px-4'>
      
      <div className='dark:text-gray-100 text-2xl font-bold mb-4'>
        <BsFilterRight style={iconStyles} size={32} />
        <span>Filter Options</span>
      </div>
      <Sidebar.Items className='px-4'>
        <Sidebar.ItemGroup>
          <div className='text-gray-600 dark:text-gray-200 flex align-middle'>
            <FaGraduationCap style={iconStyles} size={24} />
            <span className='text-lg dark:text-gray-100'>Majors</span>
          </div>
          <hr className='bottom-b-1' />
          <FilterMajor />

          <div className='text-gray-600 dark:text-gray-200 flex align-middle'>
            <FaMoneyBill1 style={iconStyles} size={24} />
            <span className='text-lg dark:text-gray-100'>Compensation</span>
          </div>
          <hr className='bottom-b-1' />

        </Sidebar.ItemGroup>
      </Sidebar.Items>
      
    </Sidebar>
  )
}
