import React from 'react'

export default function Navbar() {
  return (
    <header className='sticky top-0 z-50 flex justify-between bg-white dark:bg-slate-800 py-5 px-10 items-center text-gray-800 dark:text-gray-100 shadow-md '>
        <div className='flex'>
          <span className='2xl:text-3xl md:text-2xl text-center font-bold dark:text-gray-100'>Project Directory&nbsp;</span>
          <span className='2xl:mt-2 md:mt-1.5'>
            by&nbsp;
            <a href="https://github.com/marked01one" className='underline italic underline-offset-2'>
              marked01one
            </a>
          </span>  
            
          
        </div>
        <div className='flex w-[50%] items-center border-2 rounded-full py-2 shadow-sm'>
            <input 
            type="text"
            placeholder='Search for projects...'
            className='flex-grow pl-5 bg-transparent border-transparent focus:outline-none focus:ring-0 text-md text-white' />
        </div>
    </header>
  )
}
