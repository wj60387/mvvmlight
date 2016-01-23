using System;

namespace GalaSoft.MvvmLight.Helpers
{
    // These methods are obsoleted and will be removed in a future version.
    public partial class Binding<TSource, TTarget>
    {
        /// <summary>
        /// Define that the binding should be evaluated when the bound control's source property changes. 
        /// Because Xamarin controls are not DependencyObjects, the
        /// bound property will not automatically update the binding attached to it. Instead,
        /// use this method to specify that the binding must be updated when the property changes.
        /// </summary>
        /// <remarks>This method should only be used with the following items:
        /// <para>- an EditText control and its Text property (TextChanged event).</para>
        /// <para>- a CompoundButton control and its Checked property (CheckedChange event).</para>
        /// </remarks>
        /// <returns>The Binding instance.</returns>
        /// <exception cref="InvalidOperationException">When this method is called
        /// on a OneTime binding. Such bindings cannot be updated. This exception can
        /// also be thrown when the source object is null or has already been
        /// garbage collected before this method is called.</exception>
        [Obsolete("This method will be removed in a future version. Please use ObserveSourceEvent instead.")]
        public Binding<TSource, TTarget> UpdateSourceTrigger()
        {
            return ObserveSourceEvent();
        }

        /// <summary>
        /// Define when the binding should be evaluated when the bound source object
        /// is a control. Because Xamarin controls are not DependencyObjects, the
        /// bound property will not automatically update the binding attached to it. Instead,
        /// use this method to define which of the control's events should be observed.
        /// </summary>
        /// <param name="mode">Defines the binding's update mode. Use 
        /// <see cref="UpdateTriggerMode.LostFocus"/> to update the binding when
        /// the source control loses the focus. You can also use
        /// <see cref="UpdateTriggerMode.PropertyChanged"/> to update the binding
        /// when the source control's property changes.
        /// The PropertyChanged mode should only be used with the following items:
        /// <para>- an EditText control and its Text property (TextChanged event).</para>
        /// <para>- a CompoundButton control and its Checked property (CheckedChange event).</para>
        /// </param>
        /// <returns>The Binding instance.</returns>
        /// <exception cref="InvalidOperationException">When this method is called
        /// on a OneTime binding. Such bindings cannot be updated. This exception can
        /// also be thrown when the source object is null or has already been
        /// garbage collected before this method is called.</exception>
        [Obsolete("This method will be removed in a future version. Please use ObserveSourceEvent instead.")]
        public Binding<TSource, TTarget> UpdateSourceTrigger(UpdateTriggerMode mode)
        {
            return ObserveSourceEvent(mode);
        }

        /// <summary>
        /// Define that the binding should be evaluated when the bound control's target property changes. 
        /// Because Xamarin controls are not DependencyObjects, the
        /// bound property will not automatically update the binding attached to it. Instead,
        /// use this method to specify that the binding must be updated when the property changes.
        /// </summary>
        /// <remarks>This method should only be used with the following items:
        /// <para>- an EditText control and its Text property (TextChanged event).</para>
        /// <para>- a CompoundButton control and its Checked property (CheckedChange event).</para>
        /// </remarks>
        /// <returns>The Binding instance.</returns>
        /// <exception cref="InvalidOperationException">When this method is called
        /// on a OneTime or a OneWay binding. This exception can
        /// also be thrown when the target object is null or has already been
        /// garbage collected before this method is called.</exception>
        [Obsolete("This method will be removed in a future version. Please use ObserveTargetEvent instead.")]
        public Binding<TSource, TTarget> UpdateTargetTrigger()
        {
            return ObserveTargetEvent();
        }

        /// <summary>
        /// Define when the binding should be evaluated when the bound target object
        /// is a control. Because Xamarin controls are not DependencyObjects, the
        /// bound property will not automatically update the binding attached to it. Instead,
        /// use this method to define which of the control's events should be observed.
        /// </summary>
        /// <param name="mode">Defines the binding's update mode. Use 
        /// <see cref="UpdateTriggerMode.LostFocus"/> to update the binding when
        /// the source control loses the focus. You can also use
        /// <see cref="UpdateTriggerMode.PropertyChanged"/> to update the binding
        /// when the source control's property changes.
        /// The PropertyChanged mode should only be used with the following items:
        /// <para>- an EditText control and its Text property (TextChanged event).</para>
        /// <para>- a CompoundButton control and its Checked property (CheckedChange event).</para>
        /// </param>
        /// <returns>The Binding instance.</returns>
        /// <exception cref="InvalidOperationException">When this method is called
        /// on a OneTime or a OneWay binding. This exception can
        /// also be thrown when the source object is null or has already been
        /// garbage collected before this method is called.</exception>
        [Obsolete("This method will be removed in a future version. Please use ObserveTargetEvent instead.")]
        public Binding<TSource, TTarget> UpdateTargetTrigger(UpdateTriggerMode mode)
        {
            return ObserveTargetEvent(mode);
        }
    }
}